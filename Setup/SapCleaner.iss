#dim Version[4]
#expr ParseVersion("..\SapCleaner\bin\Release\SapCleaner.exe", Version[0], Version[1], Version[2], Version[3])
#define AppVersion Str(Version[0]) + "." + Str(Version[1]) + "." + Str(Version[2]) + "." + Str(Version[3])
#define ShortAppVersion Str(Version[0]) + "." + Str(Version[1])

[Setup]
PrivilegesRequired=none
AppName="{cm:AppName}"
AppVersion={#ShortAppVersion}
OutputBaseFilename=SapCleaner v{#ShortAppVersion}
OutputDir=Bin
DefaultDirName={pf}\SapCleaner
UsePreviousLanguage=no

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "tr"; MessagesFile: "Turkish.isl"

[Files]
Source: "..\SapCleaner\bin\Release\SapCleaner.exe"; DestDir: "{app}";
Source: "..\SapCleaner\bin\Release\ImageListView.dll"; DestDir: "{app}";
Source: "..\SapCleaner\bin\Release\FileSystemControls.dll"; DestDir: "{app}";

[CustomMessages]
AppName=Analysis File Cleaner
tr.AppName=Analiz Dosyasý Temizleyici
