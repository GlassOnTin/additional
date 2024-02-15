; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Additional"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Ian Ross Williams"
#define MyAppURL "https://github.com/GlassOnTin/additional/"
#define MyAppExeName "Additional.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{13BDEFFB-221D-4DE3-8D9F-AD445AC1FD2C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
OutputDir=.
OutputBaseFilename=additional_setup
Compression=zip
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#SourcePath}\Additional.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\Additional.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\Additional.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\Additional.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\Additional.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\AdditionalEngine.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\AdditionalEngine.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#SourcePath}\logo.png"; DestDir: "{app}"; Flags: ignoreversion

; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

