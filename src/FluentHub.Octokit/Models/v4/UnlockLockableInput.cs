// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of UnlockLockable
	/// </summary>
	public class UnlockLockableInput
	{
		/// <summary>
		/// ID of the item to be unlocked.
		/// </summary>
		public ID LockableId { get; set; }

		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }
	}
}
