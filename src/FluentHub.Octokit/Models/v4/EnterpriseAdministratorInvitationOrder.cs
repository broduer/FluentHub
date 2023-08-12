// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for enterprise administrator invitation connections
	/// </summary>
	public class EnterpriseAdministratorInvitationOrder
	{
		/// <summary>
		/// The field to order enterprise administrator invitations by.
		/// </summary>
		public EnterpriseAdministratorInvitationOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
