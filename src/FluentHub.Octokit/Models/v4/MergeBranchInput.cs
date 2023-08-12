// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of MergeBranch
	/// </summary>
	public class MergeBranchInput
	{
		/// <summary>
		/// The Node ID of the Repository containing the base branch that will be modified.
		/// </summary>
		public ID RepositoryId { get; set; }

		/// <summary>
		/// The name of the base branch that the provided head will be merged into.
		/// </summary>
		public string Base { get; set; }

		/// <summary>
		/// The head to merge into the base branch. This can be a branch name or a commit GitObjectID.
		/// </summary>
		public string Head { get; set; }

		/// <summary>
		/// Message to use for the merge commit. If omitted, a default will be used.
		/// </summary>
		public string CommitMessage { get; set; }

		/// <summary>
		/// The email address to associate with this commit.
		/// </summary>
		public string AuthorEmail { get; set; }

		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }
	}
}
