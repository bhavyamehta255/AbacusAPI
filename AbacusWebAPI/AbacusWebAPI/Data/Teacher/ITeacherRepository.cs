namespace AbacusWebAPI.Data.Teacher
{
    public interface ITeacherRepository
    {
        /// <summary>
        /// Add Teacher
        /// </summary>
        public void Add();

        /// <summary>
        /// Update Teacher Details
        /// </summary>
        public void Update();

        /// <summary>
        /// Delete Teacher
        /// </summary>
        public void Delete();

        /// <summary>
        /// Add Question
        /// </summary>
        public void AddQuestion();

        /// <summary>
        /// Get Class ALL student details
        /// </summary>
        public void GetStudentDetails();
    }
}
