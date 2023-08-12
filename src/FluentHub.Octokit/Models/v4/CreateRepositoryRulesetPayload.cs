// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of CreateRepositoryRuleset
	/// </summary>
	public class CreateRepositoryRulesetPayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The newly created Ruleset.
		/// </summary>
		public RepositoryRuleset Ruleset { get; set; }
	}
}
