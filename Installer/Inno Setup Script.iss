; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "MAL Renamer"
#define MyAppVersion "1.1"
#define MyAppPublisher "Anthony Bryan"
#define MyAppURL "https://github.com/software-2/MAL-Renamer"
#define MyAppExeName "MAL Renamer.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{83EC71AF-C08E-4EB7-BE56-3C1E861946E5}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; The [Icons] "quicklaunchicon" entry uses {userappdata} but its [Tasks] entry has a proper IsAdminInstallMode Check.
UsedUserAreasWarning=no
LicenseFile=E:\Git\MAL-Renamer\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=E:\Git\MAL-Renamer\Installer
OutputBaseFilename=Installer
SetupIconFile=E:\Git\MAL-Renamer\icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\MAL Renamer.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\MAL Renamer.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\MAL Renamer.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\RestSharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Git\MAL-Renamer\MAL-Renamer\bin\Release\RestSharp.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

