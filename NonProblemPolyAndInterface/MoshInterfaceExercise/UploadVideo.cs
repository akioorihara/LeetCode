using System;
namespace MoshInterfaceExercise
{
	public class UploadVideo : IUpload, IWorkflow
	{
        //public string Path;
        private string _path;

		public UploadVideo(string path)
		{
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));
            _path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Execute()
        {
            Upload();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// uploading a video
        /// </summary>
        public void Upload()
        {
            //_path = path;
            Console.WriteLine("Uploading a video......");
            //throw new NotImplementedException();
        }
    }
}

