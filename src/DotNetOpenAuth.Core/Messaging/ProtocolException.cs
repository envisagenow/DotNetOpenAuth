﻿//-----------------------------------------------------------------------
// <copyright file="ProtocolException.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Messaging {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Security;
	using System.Security.Permissions;

	/// <summary>
	/// An exception to represent errors in the local or remote implementation of the protocol.
	/// </summary>
	[Serializable]
	public class ProtocolException : Exception {
		/// <summary>
		/// Initializes a new instance of the <see cref="ProtocolException"/> class.
		/// </summary>
		public ProtocolException() {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ProtocolException"/> class.
		/// </summary>
		/// <param name="message">A message describing the specific error the occurred or was detected.</param>
		public ProtocolException(string message) : base(message) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ProtocolException"/> class.
		/// </summary>
		/// <param name="message">A message describing the specific error the occurred or was detected.</param>
		/// <param name="inner">The inner exception to include.</param>
		public ProtocolException(string message, Exception inner) : base(message, inner) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ProtocolException"/> class
		/// such that it can be sent as a protocol message response to a remote caller.
		/// </summary>
		/// <param name="message">The human-readable exception message.</param>
		/// <param name="faultedMessage">The message that was the cause of the exception.  May be null.</param>
		/// <param name="innerException">The inner exception to include.</param>
		protected internal ProtocolException(string message, IProtocolMessage faultedMessage, Exception innerException = null)
			: base(message, innerException) {
			this.FaultedMessage = faultedMessage;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ProtocolException"/> class.
		/// </summary>
		/// <param name="info">The <see cref="System.Runtime.Serialization.SerializationInfo"/> 
		/// that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The System.Runtime.Serialization.StreamingContext 
		/// that contains contextual information about the source or destination.</param>
		protected ProtocolException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) {
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the message that caused the exception.
		/// </summary>
		internal IProtocolMessage FaultedMessage { get; private set; }
	}
}
