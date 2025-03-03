namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Protection Profile custom input.</summary>
    public partial class ProtectionProfileCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IProtectionProfileCustomDetailsInternal
    {

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Creates an new <see cref="ProtectionProfileCustomDetails" /> instance.</summary>
        public ProtectionProfileCustomDetails()
        {

        }
    }
    /// Protection Profile custom input.
    public partial interface IProtectionProfileCustomDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }

    }
    /// Protection Profile custom input.
    internal partial interface IProtectionProfileCustomDetailsInternal

    {
        /// <summary>The class type.</summary>
        string ResourceType { get; set; }

    }
}