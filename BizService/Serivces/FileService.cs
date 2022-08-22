using System.IO;
using System.Threading.Tasks;

namespace BizService.Services;

public class FileService : ServiceBase
{
    protected override string Path => "file";

    async public Task<string> UploadImage(string imagePath)
    {
        var imageBytes = ReadImageFile(imagePath);

        var url = await this.PostFileAsync<string>(Path, imageBytes, System.IO.Path.GetFileName(imagePath));
        return url;
    }

    private byte[] ReadImageFile(string imagePath)
    {
        byte[] imageData = null;
        FileInfo fileInfo = new FileInfo(imagePath);
        long imageFileLength = fileInfo.Length;
        FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs);
        imageData = br.ReadBytes((int)imageFileLength);
        return imageData;
    }

}
