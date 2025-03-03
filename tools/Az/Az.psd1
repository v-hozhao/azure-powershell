#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2021/7/29
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '6.3.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://docs.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.5.2'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '2.2.0'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.7.1'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '4.16.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '2.2.3'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.13.1'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.8.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.3'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '3.4.5'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '2.7.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '4.10.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '2.3.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '4.5.0'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '3.4.1'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '3.10.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.0.4'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.8.1'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '6.3.0 - August 2021
Az.Accounts
* Disabled context auto saving when token cache persistence fails on Windows and macOS
* Added PowerShell version into telemetry record
* Upgraded Microsoft.ApplicationInsights from 2.4.0 to 2.12.0
* Updated Azure.Core to 1.16.0

Az.Aks
* Added ''Start-AzAksCluster'', ''Stop-AzAksCluster'', ''Get-AzAksUpgradeProfile'' and ''Get-AzAksNodePoolUpgradeProfile''. [#14194]
* Added property ''IdentityProfile'' in the output of ''Get-AzAksCluster''. [#12546]

Az.CognitiveServices
* [Breaking Change] Changed type of PSCognitiveServicesAccount.Identity.Type from IdentityType to ResourceIdentityType.
* [Breaking Change] Changed type of PSCognitiveServicesAccount.Sku.Tier from SkuTier to string.
* [Breaking Change] Removed ActionRequired from PrivateLinkServiceConnectionState.
* Updated PowerShell to use 2021-04-30 version.
* Added ''Undo-AzCognitiveServicesAccountRemoval'' cmdlet.
* Added parameters ''-RestrictOutboundNetworkAccess'', ''-AllowedFqdnList'', ''-DisableLocalAuth'', ''-KeyVaultIdentityClientId'', ''-IdentityType'', ''-UserAssignedIdentityId'' to ''New-AzureCognitiveServicesAccount'' and ''Set-AzureCognitiveServicesAccount''.
* Added parameters ''-InRemovedState'', ''-Location'' to ''Remove-AzureCognitiveServicesAccount'' and ''Get-AzureCognitiveServicesAccount''.

Az.Compute
* Fixed the warning in ''New-AzVM'' cmdlet stating the sku of the VM is being defaulted even if a sku size is provided by the user. Now it only occurs when the user does not provide a sku size.
* Edited ''Set-AzVmOperatingSystem'' cmdlet to no longer overwrite any existing EnableAutomaticUpdates value on the passed in virtual machine if it exists.
* Updated Compute module to use the latest .Net SDK version 48.0.0.
* Added new cmdlets for the Capacity Reservation Feature:
    - ''New-AzCapacityReservationGroup''
    - ''Remove-AzCapacityReservationGroup''
    - ''Get-AzCapacityReservationGroup''
    - ''New-AzCapacityReservation''
    - ''Remove-AzCapacityReservation''
    - ''Get-AzCapacityReservation''
* Added a new parameter ''-CapacityReservationGroupId'' to the following cmdlets:
    - ''New-AzVm''
    - ''New-AzVmConfig''
    - ''New-AzVmss''
    - ''New-AzVmssConfig''
    - ''Update-AzVm''
    - ''Update-AzVmss''

Az.DataFactory
* Updated ADF .Net SDK version to 4.21.0

Az.Migrate
* Added SQL Server license type.
* Added CRN feature.
* Added resource tags feature.
* Updated to 2021-02-10 api version.

Az.Monitor
* Added parameter ''ResourceGroupName'' back for ''Add-AzAutoscaleSetting'' parameter set ''AddAzureRmAutoscaleSettingUpdateParamGroup'' and made it optional [#15491]

Az.RecoveryServices
* Added Archive for V1 vaults.
* Added ProtectedItemsCount in Get-AzRecoveryServicesBackupProtectionPolicy.
* Azure site recovery bug fix for azure to azure in update vm properties.

Az.RedisCache
* Added ''RedisVersion'' parameter in ''New-AzRedisCache'' and ''Set-AzRedisCache''

Az.Resources
* Fixed bug with ''PSResource'' where some constructors left ''SubscriptionId'' property unassigned/null.  [#10783]
* Added support for creating and updating Template Spec in Bicep file [#15313]
* Added ''-ProceedIfNoChange'' parameter to deployment create cmdlets.

Az.ServiceFabric
* Fixed Managed and Classic Application models (Application, Cluster, Service) by updating constructor to take all new properties
    - This solves piping related issues where piping the results directly from a Get cmdlet call into and Update or Set call remove some intentionally set properties
    - Updated appropriate test files to cover the above mentioned cases

Az.Sql
* Fixed identity logic in ''Set-AzSqlServer'' and ''Set-AzSqlInstance''

Az.Storage
* Supported Blob Last Access Time
    -  ''Enable-AzStorageBlobLastAccessTimeTracking''
    -  ''Disable-AzStorageBlobLastAccessTimeTracking''
    -  ''Add-AzStorageAccountManagementPolicyAction''
* Made ''Get-AzDataLakeGen2ChildItem'' list all datalake gen2 items by default, instead of needing user to list chunk by chunk.
* Fixed BlobProperties is empty issue when using sas without prefix ''?'' [#15460]
* Fixed synchronously copy small blob failure [#15548]
    - ''Copy-AzStorageBlob''

Az.Websites
* Fixed ''Add-AzWebAppAccessRestrictionRule'' failing when users does not have permissions to get Service Tag list #15316 and #14862
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

