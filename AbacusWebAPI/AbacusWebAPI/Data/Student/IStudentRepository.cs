namespace AbacusWebAPI.Data.Student
{
    public interface IStudentRepository
    {
        /// <summary>
        /// Add Student
        /// </summary>
        public void Add();

        /// <summary>
        /// Update Student Details
        /// </summary>
        public void Update();

        /// <summary>
        /// Delete Student
        /// </summary>
        public void Delete();

        /// <summary>
        /// Update Exam ScoreCard
        /// </summary>
        public void UpdateScoreCard();

        /// <summary>
        /// Get ScoreCard History Data
        /// </summary>
        public void GetScoreCardHistory();

        /// <summary>
        /// Get Question Paper
        /// </summary>
        /// <param name="level"></param>
        public void GetExamQuestions(int level);
    }
}
