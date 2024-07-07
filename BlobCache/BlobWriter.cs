namespace BlobCache;

public interface IBlobWriter {
    IRecordPointer Write(ref readonly byte[] buffer);
}
