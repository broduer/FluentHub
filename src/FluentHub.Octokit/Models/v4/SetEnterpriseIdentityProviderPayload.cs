// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of SetEnterpriseIdentityProvider
	/// </summary>
	public class SetEnterpriseIdentityProviderPayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The identity provider for the enterprise.
		/// </summary>
		public EnterpriseIdentityProvider IdentityProvider { get; set; }
	}
}
