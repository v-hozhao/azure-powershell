namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>A2A provider specific settings.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2ACrossClusterMigrationReplicationDetailsTypeConverter))]
    public partial class A2ACrossClusterMigrationReplicationDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2ACrossClusterMigrationReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2ACrossClusterMigrationReplicationDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).PrimaryFabricLocation = (string) content.GetValueForProperty("PrimaryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).PrimaryFabricLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).OSType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionState = (string) content.GetValueForProperty("VMProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionStateDescription = (string) content.GetValueForProperty("VMProtectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionStateDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).LifecycleId = (string) content.GetValueForProperty("LifecycleId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).LifecycleId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2ACrossClusterMigrationReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2ACrossClusterMigrationReplicationDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).FabricObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).PrimaryFabricLocation = (string) content.GetValueForProperty("PrimaryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).PrimaryFabricLocation, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).OSType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionState = (string) content.GetValueForProperty("VMProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionStateDescription = (string) content.GetValueForProperty("VMProtectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).VMProtectionStateDescription, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).LifecycleId = (string) content.GetValueForProperty("LifecycleId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetailsInternal)this).LifecycleId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IReplicationProviderSpecificSettingsInternal)this).InstanceType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2ACrossClusterMigrationReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2ACrossClusterMigrationReplicationDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.A2ACrossClusterMigrationReplicationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2ACrossClusterMigrationReplicationDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2ACrossClusterMigrationReplicationDetails" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IA2ACrossClusterMigrationReplicationDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A2A provider specific settings.
    [System.ComponentModel.TypeConverter(typeof(A2ACrossClusterMigrationReplicationDetailsTypeConverter))]
    public partial interface IA2ACrossClusterMigrationReplicationDetails

    {

    }
}