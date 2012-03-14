using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace MavenThought.MediaLibrary.Core.Tests
{
    /// <summary>
    /// Specification when changing the movie title
    /// </summary>
    [Specification]
    public class When_movie_gets_title_assigned : MovieSpecification
    {
        /// <summary>
        /// New title to assign
        /// </summary>
        private readonly string _newTitle;

        /// <summary>
        /// Initializes <see cref="When_movie_gets_title_assigned"/>
        /// </summary>
        public When_movie_gets_title_assigned()
        {
            _newTitle = "The Adventures Of PRDC";
        }

        /// <summary>
        /// Checks the title was updated
        /// </summary>
        [It]
        public void Should_update_the_title()
        {
            this.Sut.Title.Should().Be(this._newTitle);
        }

        /// <summary>
        /// Assigns the title to the movie
        /// </summary>
        protected override void WhenIRun()
        {
            this.ConcreteSut.Title = this._newTitle;
        }
    }
}