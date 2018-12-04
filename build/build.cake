#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
#addin "Cake.FileHelpers"
#tool "nuget:?package=OctopusTools"
#tool "nuget:?package=GitVersion.CommandLine&version=3.6.5"
#addin "nuget:?package=Cake.Sonar"
#tool "nuget:?package=MSBuild.SonarQube.Runner.Tool"

#addin "Cake.FileHelpers&version=3.1.0"
#addin nuget:?package=Cake.Coverlet&Version=1.3.2
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////


var target = Argument("target", "Default");
var productName = Argument<string>("productName", "eShopOnWeb");
//var deployRoot = Argument<string>("deployRoot",  MakeAbsolute(Directory("../deploy/product")).FullPath);
var outputPath = Argument<string>("outputPath", MakeAbsolute(Directory("./output")).FullPath);
var configuration = Argument("configuration","Release");
var solutionRoot = Argument<string>("solutionRoot", MakeAbsolute(Directory("..")).FullPath);


/// VARIABLES
var solutionLocation = MakeAbsolute(Directory($"{solutionRoot}/src"));
var versionInfo = GitVersion(new GitVersionSettings());
var runtime = Argument<string>("runtime", "win-x64");
var projectLocation = $"src/{productName}";
var project = File($"{solutionRoot}/{projectLocation}/{productName}.csproj");
var outputPackagePath = MakeAbsolute(Directory("./package")).FullPath;
var tempPath = MakeAbsolute(Directory("./temp")).FullPath;

var functionalTests = File($"{solutionRoot}/tests/FunctionalTests/FunctionalTests.csproj");
var integrationTests = File($"{solutionRoot}/tests/IntegrationTests/IntegrationTests.csproj");
var unitTests = File($"{solutionRoot}/tests/UnitTests/UnitTests.csproj");
var outputBuildPath = Directory(outputPath) + Directory("build");
var testResultFileName = $"{productName}_TestResult_{DateTime.UtcNow:dd-MM-yyyy-HH-mm-ss-FFF}.xml";
var testCoverageFileName = $"{productName}_TestCoverageResults_{DateTime.UtcNow:dd-MM-yyyy-HH-mm-ss-FFF}.xml";

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("dummi")
.Description("Do any test here in cake")
.Does(() => {

Information($"Searching for directories in {solutionLocation}");

var semver = versionInfo.ToString();
Information(semver);

foreach(DirectoryPath dir in GetSubDirectories(solutionLocation))
{
    Information($"Directory {dir} found.");
    var segments = dir.Segments;
    Information(segments[segments.Count()-1]);
    
}
 
} );



Task("Clean")
    .Description("Cleans all directories that are used during the build process.")
    .Does(() =>
{
    //Clean the release directory
    Information("Cleaning {0}", outputPath);
    foreach (var file in GetFiles($"{outputPath}/**/*"))
    {
        System.IO.File.SetAttributes($"{file}", FileAttributes.Normal);
    }
    CleanDirectories(outputPath);
    
    Information("Cleaning {0}", outputPackagePath);
    foreach (var file in GetFiles($"{outputPackagePath}/**/*"))
    {
        System.IO.File.SetAttributes($"{file}", FileAttributes.Normal);
    }
    CleanDirectories(outputPackagePath);
});

Task("RestoreNuGetPackages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore("../eShopOnWeb.sln");
});


Task("Build")
    .Description("Builds the project.")
    .IsDependentOn("RestoreNuGetPackages")
    .Does(() =>
{
    // Build the project.
    Information("Building {0} to location {1}", project, outputPath);

    Information("InformationalVersion: {0}", versionInfo.InformationalVersion);
    Information("MajorMinorPatch: {0}", versionInfo.MajorMinorPatch);
    Information("AssemblySemFileVer: {0}", versionInfo.AssemblySemFileVer);
    Information("AssemblySemVer: {0}", versionInfo.AssemblySemVer);
    Information("FullSemVer: {0}", versionInfo.FullSemVer);
    Information("SemVer: {0}", versionInfo.SemVer);
    Information("Nuget v2 version: {0}", versionInfo.NuGetVersionV2);

    var buildSettings = new DotNetCoreBuildSettings()
        {
            Configuration = configuration,
            Runtime = runtime,
            ArgumentCustomization = args => args
                .Append($"/p:Version={versionInfo.SemVer}")
                .Append($"/p:FileVersion={versionInfo.SemVer}")
                .Append("/nodereuse:false") // https://github.com/SonarSource/sonar-scanner-msbuild/issues/535
        };

    foreach(DirectoryPath dir in GetSubDirectories(solutionLocation))
    {
            
        var pathSegments = dir.Segments;
        productName =  pathSegments[pathSegments.Count()-1];
        projectLocation = $"src/{productName}";
        project = File($"{solutionRoot}/{projectLocation}/{productName}.csproj");

        DotNetCoreBuild(project, buildSettings);
    }
    
    if (FileExists(functionalTests))
    {
        buildSettings.Runtime = string.Empty; // If specified, output path will be under win-x64 which fails testing
        DotNetCoreBuild(functionalTests, buildSettings);
    }
    if (FileExists(integrationTests))
    {
        buildSettings.Runtime = string.Empty; // If specified, output path will be under win-x64 which fails testing
        DotNetCoreBuild(integrationTests, buildSettings);
    }
    if (FileExists(unitTests))
    {
        buildSettings.Runtime = string.Empty; // If specified, output path will be under win-x64 which fails testing
        DotNetCoreBuild(unitTests, buildSettings);
    }

});


Task("Test")  
    .IsDependentOn("Build")
    .Does(() =>
    {
        if (FileExists(functionalTests))
        {
            DotNetCoreTest(
                        functionalTests,
                        new DotNetCoreTestSettings()
                        {
                            Configuration = configuration,
                            NoBuild = true,
                            ResultsDirectory = outputBuildPath,
                            Logger = $"trx;LogFileName=functionalTests_{testResultFileName}"
                        },
                        new CoverletSettings {
                            CollectCoverage = true,
                            CoverletOutputFormat = CoverletOutputFormat.opencover,
                            CoverletOutputDirectory = outputBuildPath,
                            CoverletOutputName = testCoverageFileName
                        });
        }
        if (FileExists(integrationTests))
        {
            DotNetCoreTest(
                        integrationTests,
                        new DotNetCoreTestSettings()
                        {
                            Configuration = configuration,
                            NoBuild = true,
                            ResultsDirectory = outputBuildPath,
                            Logger = $"trx;LogFileName=integrationTests_{testResultFileName}"
                        },
                        new CoverletSettings {
                            CollectCoverage = true,
                            CoverletOutputFormat = CoverletOutputFormat.opencover,
                            CoverletOutputDirectory = outputBuildPath,
                            CoverletOutputName = testCoverageFileName
                        });
        }
        if (FileExists(unitTests))
        {
            DotNetCoreTest(
                        unitTests,
                        new DotNetCoreTestSettings()
                        {
                            Configuration = configuration,
                            NoBuild = true,
                            ResultsDirectory = outputBuildPath,
                            Logger = $"trx;LogFileName=unitTests_{testResultFileName}"
                        },
                        new CoverletSettings {
                            CollectCoverage = true,
                            CoverletOutputFormat = CoverletOutputFormat.opencover,
                            CoverletOutputDirectory = outputBuildPath,
                            CoverletOutputName =  testCoverageFileName
                        });
        }

    });



Task("Publish")
    .Description("Publishes the project.")
    .IsDependentOn("Build")
    .Does(() =>
{
    // Build the project.
    foreach(DirectoryPath dir in GetSubDirectories(solutionLocation))
    {
        var pathSegments = dir.Segments;
        productName =  pathSegments[pathSegments.Count()-1];
        outputPath = MakeAbsolute(Directory($"./output/{productName}")).FullPath;
        projectLocation = $"src/{productName}";
        project = File($"{solutionRoot}/{projectLocation}/{productName}.csproj");

        Information("Publishing {0} to location {1}", project, outputPath);

        DotNetCorePublish(project, 
            new DotNetCorePublishSettings()
            {
                Configuration = configuration,
                Runtime = runtime,
                OutputDirectory = outputPath,
                ArgumentCustomization = args => args
                    .Append($"/p:Version={versionInfo.NuGetVersionV2}")
                    .Append($"/p:FileVersion={versionInfo.NuGetVersionV2}")
            }
        );

    }
    
});

Task("Package")
    .Description("Creates the deployment package (.zip files).")
    .IsDependentOn("Publish")
    .Does(() =>
{
    var deployRoot = MakeAbsolute(Directory("../build/output")).FullPath; //use this one later for zipped files

    foreach (var file in GetFiles($"{deployRoot}/**/*"))
    {
        //Information($"Modifying {file} ");
        System.IO.File.SetAttributes($"{file}", FileAttributes.Normal);
    }
    
    Information("Creating deployment package {0} archive at {1}", deployRoot, outputPackagePath);
    Zip($"{deployRoot}/", $"{outputPackagePath}/eShopOnWeb_{versionInfo.SemVer}.zip");
    
});


Task("Default")
    .Description("This is the default task which will be run if no specific target is passed in.")
    .IsDependentOn("Build");


RunTarget(target);
