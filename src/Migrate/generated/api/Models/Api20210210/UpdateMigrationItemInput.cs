namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Update migration item input.</summary>
    public partial class UpdateMigrationItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateMigrationItemInputProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputProperties _property;

        /// <summary>Update migration item input properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.UpdateMigrationItemInputProperties()); set => this._property = value; }

        /// <summary>The provider specific input to update migration item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemProviderSpecificInput ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputPropertiesInternal)Property).ProviderSpecificDetail = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="UpdateMigrationItemInput" /> instance.</summary>
        public UpdateMigrationItemInput()
        {

        }
    }
    /// Update migration item input.
    public partial interface IUpdateMigrationItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The provider specific input to update migration item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provider specific input to update migration item.",
        SerializedName = @"providerSpecificDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemProviderSpecificInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemProviderSpecificInput ProviderSpecificDetail { get; set; }

    }
    /// Update migration item input.
    internal partial interface IUpdateMigrationItemInputInternal

    {
        /// <summary>Update migration item input properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemInputProperties Property { get; set; }
        /// <summary>The provider specific input to update migration item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IUpdateMigrationItemProviderSpecificInput ProviderSpecificDetail { get; set; }

    }
}