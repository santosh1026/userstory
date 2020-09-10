namespace AzureBlobStorageLRS
{
    public class SaveBlobRequest
    {
        public string BlobContentBase64 { get; set; }

        public string BlobName { get; set; }
    }
}