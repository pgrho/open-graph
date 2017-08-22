namespace Shipwreck.OpenGraph
{
    /// <summary>
    /// Represents contact data that can attached to other <see cref="GraphObject"/>.
    /// </summary>
    public sealed partial class ContactData : GraphObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactData" /> class.
        /// </summary>
        public ContactData()
            : this(new PropertyPath(NamespaceCollection.Business, "contact_data"))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactData" /> class with specified property path.
        /// </summary>
        /// <param name="path">A property path for this instance.</param>
        internal ContactData(PropertyPath path)
            : base(path)
        {
        }
    }
}