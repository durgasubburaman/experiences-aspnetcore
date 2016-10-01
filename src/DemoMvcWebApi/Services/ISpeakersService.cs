using System.Collections.Generic;

namespace DemoMvcWebApi.Services
{
    /// <summary>
    /// Defines a contract for speakers service
    /// </summary>
    public interface ISpeakersService
    {
        /// <summary>
        /// Gets all the speakers
        /// </summary>
        /// <returns></returns>
        IList<Models.Speaker> GetSpeakers();

        /// <summary>
        /// Gets a speaker by its id
        /// </summary>
        /// <param name="id">The id of the speaker</param>
        /// <returns>The speaker</returns>
        Models.Speaker GetSpeaker(int id);

        /// <summary>
        /// Updates a speaker
        /// </summary>
        /// <param name="speaker">The speaker to udpate</param>
        void UpdateSpeaker(Models.Speaker speaker);

        /// <summary>
        /// Adds a speaker and returns its id
        /// </summary>
        /// <param name="speaker"></param>
        int AddSpeaker(Models.Speaker speaker);

        /// <summary>
        /// Deletes a speaker
        /// </summary>
        /// <param name="speaker">The speaker to delete</param>
        void DeleteSpeaker(Models.Speaker speaker);
    }
}
