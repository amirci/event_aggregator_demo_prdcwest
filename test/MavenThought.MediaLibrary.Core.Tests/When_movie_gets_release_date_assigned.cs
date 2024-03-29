using System;
using MavenThought.Commons.Testing;
using NUnit.Framework;
using SharpTestsEx;

namespace MavenThought.MediaLibrary.Core.Tests
{
    /// <summary>
    /// Specification when assigning the release date
    /// </summary>
    [Specification]
    public class When_movie_gets_release_date_assigned : MovieSpecification
    {
        /// <summary>
        /// New value to assign
        /// </summary>
        private readonly DateTime _expected;

        /// <summary>
        /// Initializes <see cref="When_movie_gets_title_assigned"/>
        /// </summary>
        public When_movie_gets_release_date_assigned()
        {
            _expected = DateTime.Now.AddDays(3);
        }

        /// <summary>
        /// Checks the value was updated
        /// </summary>
        [It]
        public void Should_update_the_release_date()
        {
            this.Sut.ReleaseDate.Should().Be.EqualTo(this._expected);
        }

        /// <summary>
        /// Assigns the title to the movie
        /// </summary>
        protected override void WhenIRun()
        {
            this.ConcreteSut.ReleaseDate = this._expected;
        }      
    }
}