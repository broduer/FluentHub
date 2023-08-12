// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Types that can be inside Project Cards.
	/// </summary>
	public class ProjectCardItem
	{
		/// <summary>
		/// An Issue is a place to discuss ideas, enhancements, tasks, and bugs for a project.
		/// </summary>
		public Issue Issue { get; set; }

		/// <summary>
		/// A repository pull request.
		/// </summary>
		public PullRequest PullRequest { get; set; }
	}
}
