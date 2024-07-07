namespace BlobCache;

public interface IBlobReader {
    byte[] Read(ref readonly IRecordPointer pointer);
}
