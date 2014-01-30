using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;

namespace Backend
{
    public interface IResumeRepository
    {
        UserResume GetUserResume(int resumeId);
        int SaveResume(UserResume userResume);
        UserResume UpdateResume(UserResume userResume);
    }

    public class ResumeRepository : IResumeRepository
    {
        private readonly string _resumeStorePath = @"c:\_AngularResumes\";

        public ResumeRepository()
        {
        }

        public ResumeRepository(string resumeStorePath)
        {
            if (!string.IsNullOrWhiteSpace(resumeStorePath))
            {
                _resumeStorePath = resumeStorePath;
            }
        }
        
        public UserResume GetUserResume(int resumeId)
        {
            var resumePath = _resumeStorePath + resumeId + ".json"; 
            
            if (File.Exists(resumePath))
            {
                string userResumeString = File.ReadAllText(resumePath);
                return JsonConvert.DeserializeObject<UserResume>(userResumeString);
            }

            throw new Exception(string.Format("User Resume with ID: {0} does not exists.", resumeId));
        }

        public int SaveResume(UserResume userResume)
        {
            var nextResumeId = GetNextResumeId();
            var resumePath = _resumeStorePath + nextResumeId + ".json"; 
            userResume.UserResumeId = nextResumeId;

            SaveResumeToFile(resumePath, userResume);
            return nextResumeId;
        }

        public UserResume UpdateResume(UserResume userResume)
        {
            var resumePath = _resumeStorePath + userResume.UserResumeId + ".json";
            SaveResumeToFile(resumePath, userResume);
            return userResume;
        }

        private void SaveResumeToFile(string resumeFullPath, UserResume resume)
        {
            if (File.Exists(resumeFullPath))
            {
                File.Delete(resumeFullPath);
            }

            string resumeSerialized = JsonConvert.SerializeObject(resume, Formatting.Indented);
            File.WriteAllText(resumeFullPath, resumeSerialized);
        }

        private int GetNextResumeId()
        {
            if (Directory.Exists(_resumeStorePath))
            {
                var filesInDirectory = Directory.GetFiles(_resumeStorePath);
                if (filesInDirectory.Length > 0)
                {
                    return filesInDirectory.Length + 1;
                }

                return 1;
            }

            throw new Exception(string.Format("Directory for resumes {0} does not exists.", _resumeStorePath));
        }

    }
}
