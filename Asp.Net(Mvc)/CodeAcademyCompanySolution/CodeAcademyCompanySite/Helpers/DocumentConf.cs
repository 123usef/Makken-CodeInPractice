namespace CodeAcademyCompany.PL.Helpers
{
    public static class DocumentConf
    {
        public static string DocumentUpload(IFormFile file , string folderName)
        {
            //1.detect FolderPath

            //string folderPath = "D:\\Makeen-Ptach3\\CodeInPractice\\Asp.Net(Mvc)\\CodeAcademyCompanySolution\\CodeAcademyCompanySite\\wwwroot\\Files\\" + folderName; // wrong
            //string folderPath = Directory.GetCurrentDirectory() + "\\wwwroot\\Files\\" + folderName; 
            //string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "\\wwwroot\\Files\\" , folderName);
            string folderpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", folderName);
            // Generate FileName
            // Guid ==> 32 bit numerical Representation 
            string fileName =  $"{Guid.NewGuid()}{file.FileName}"; //unique
            //Generate FilePath
            string FilePath = Path.Combine(folderpath, fileName);
            //filestream Channel for streaming the file as bytes 
            var fs = new FileStream(FilePath, FileMode.Create);
            file.CopyTo(fs);

            
            return fileName;

        }
        public static void DcoumentDelete(string fileName , string FolderName)
        {

            if (fileName is not null)
            {
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", FolderName , fileName);
                if (File.Exists(filepath))
                {
                    File.Delete(filepath);

                }

            }

        }
    }
}
