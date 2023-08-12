// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of CreateMigrationSource
	/// </summary>
	public class CreateMigrationSourcePayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The created migration source.
		/// </summary>
		public MigrationSource MigrationSource { get; set; }
	}
}
