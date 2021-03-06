#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Messages.Messages
File: ConnectionStates.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Messages
{
	/// <summary>
	/// Connection states.
	/// </summary>
	public enum ConnectionStates
	{
		/// <summary>
		/// Non active.
		/// </summary>
		Disconnected,

		/// <summary>
		/// Disconnect pending.
		/// </summary>
		Disconnecting,

		/// <summary>
		/// Connect pending.
		/// </summary>
		Connecting,

		/// <summary>
		/// Connection active.
		/// </summary>
		Connected,

		/// <summary>
		/// Error connection.
		/// </summary>
		Failed,
	}
}
