// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Result for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.ListSharedFoldersAsync" />.</para>
    /// <para>Unmounted shared folders can be identified by the absence of <see
    /// cref="SharedFolderMetadata.PathLower" />.</para>
    /// </summary>
    public sealed class ListSharedFoldersResult : enc.IEncodable<ListSharedFoldersResult>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListSharedFoldersResult" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">List of all shared folders the authenticated user has access
        /// to.</param>
        public ListSharedFoldersResult(col.IEnumerable<SharedFolderMetadata> entries)
        {
            var entriesList = new col.List<SharedFolderMetadata>(entries ?? new SharedFolderMetadata[0]);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            this.Entries = entriesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListSharedFoldersResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListSharedFoldersResult()
        {
        }

        /// <summary>
        /// <para>List of all shared folders the authenticated user has access to.</para>
        /// </summary>
        public col.IList<SharedFolderMetadata> Entries { get; private set; }

        #region IEncodable<ListSharedFoldersResult> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListSharedFoldersResult>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddFieldObjectList<SharedFolderMetadata>("entries", this.Entries);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListSharedFoldersResult enc.IEncodable<ListSharedFoldersResult>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Entries = new col.List<SharedFolderMetadata>(obj.GetFieldObjectList<SharedFolderMetadata>("entries"));
            }

            return this;
        }

        #endregion
    }
}
