using System;
using System.Net;

namespace BlitzDocs
{
    public class BlitzDocsServices
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public Guid ImpersonatedUserId { get; set; }

        public Guid UploadFile(int folderId, byte[] document, string title)
        {
            var client = new Indexing.Indexing { Credentials = Credentials };
            return client.IndexFileBase64(
                containsBarcodes: false,
                processUsingADR: false,
                folderId: folderId,
                documentTypeListId: (short)252, // 252=Mortgage Docs
                documentTypeId: (short)36, // 36=Disclosure package (PR & subsequent)
                title: title,
                comments: string.Empty,
                fileContentType: "pdf",
                receiptCookie: string.Empty,
                impersonatedUserId: ImpersonatedUserId,
                batchId: string.Empty,
                document: document);
        }

        public void GetDocuments(int folderId)
        {
            var client = new Folder.FolderService { Credentials = Credentials };
            var documents = client.GetDocumentsEx(folderId, ImpersonatedUserId);
            foreach(var document in documents)
            {
                var documentId = document.DocumentId;
                GetDocumentContent(folderId, documentId);
            }
        }

        public byte[] GetDocumentContent(int folderId, int documentId)
        {
            var client = new FolderDocument.FolderDocumentService { Credentials = Credentials };
            return client.GetDocumentContent(folderId, documentId);
        }

        private ICredentials Credentials => new NetworkCredential(UserName, Password, Domain);
    }
}
