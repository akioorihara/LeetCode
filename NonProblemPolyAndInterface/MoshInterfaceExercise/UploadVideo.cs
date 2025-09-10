using System;
namespace MoshInterfaceExercise
{
	public class UploadVideo : IUpload
	{
        public string Path;
        private string _path;

		public UploadVideo()
		{
            //_path = "";

        }

        /// <summary>
        /// uploading a video
        /// </summary>
        public void Upload(string path)
        {
            Path = path;
            Console.WriteLine("Uploading a video");
            //throw new NotImplementedException();
        }
    }
}

