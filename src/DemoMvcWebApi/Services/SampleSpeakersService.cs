using System.Collections.Generic;
using System.Linq;
using DemoMvcWebApi.Models;

namespace DemoMvcWebApi.Services
{
    /// <summary>
    /// Sample speakers service
    /// </summary>
    public class SampleSpeakersService : ISpeakersService
    {
        /// <summary>
        /// Gets a speaker by its id
        /// </summary>
        /// <param name="id">The id of the speaker</param>
        /// <returns>The speaker</returns>
        public Speaker GetSpeaker(int id)
        {
            return this.GetSpeakers().FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Gets all the speakers
        /// </summary>
        /// <returns></returns>
        public IList<Speaker> GetSpeakers()
        {
            return new List<Speaker>()
            {
                new Speaker() { Company = "Microsoft", FirstName = "Satya", Id = 1, Job = "CEO", LastName = "Nadella" },
                new Speaker() { Company = "Microsoft", FirstName = "Scott", Id = 2, Job = "VP Cloud + Enterprise", LastName = "Guthrie" },
                new Speaker() { Company = "Microsoft", FirstName = "Scott", Id = 3, Job = "PPM ASP.NET/.NET", LastName = "Hanselman" },
                new Speaker() { Company = "Microsoft", FirstName = "Brad", Id = 4, Job = "President and Chief legal Officer", LastName = "Smith" },
                new Speaker() { Company = "Microsoft France", FirstName = "Benjamin", Id = 5, Job = "Technical Evangelist", LastName = "Talmard" },
                new Speaker() { Company = "Microsoft France", FirstName = "Julien", Id = 6, Job = "Technical Evangelist", LastName = "Corioland" },
                new Speaker() { Company = "Docker, Inc", FirstName = "Ben", Id = 7, Job = "CEO", LastName = "Golub" }
            };
        }

        /// <summary>
        /// Adds a speaker and returns its id
        /// </summary>
        /// <param name="speaker"></param>
        public int AddSpeaker(Speaker speaker)
        {
            return -1;
        }

        /// <summary>
        /// Deletes a speaker
        /// </summary>
        /// <param name="speaker">The speaker to delete</param>
        public void DeleteSpeaker(Speaker speaker)
        {
            // nothing
        }

        /// <summary>
        /// Updates a speaker
        /// </summary>
        /// <param name="speaker">The speaker to udpate</param>
        public void UpdateSpeaker(Speaker speaker)
        {
            // nothing
        }
    }
}
