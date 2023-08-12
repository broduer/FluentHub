// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for sponsorship connections.
	/// </summary>
	public class SponsorshipOrder
	{
		/// <summary>
		/// The field to order sponsorship by.
		/// </summary>
		public SponsorshipOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
