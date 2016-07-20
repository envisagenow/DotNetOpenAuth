﻿//-----------------------------------------------------------------------
// <copyright file="OAuth1RsaSha1HttpMessageHandler.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------


namespace DotNetOpenAuth.OAuth {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Security.Cryptography;
	using System.Security.Cryptography.X509Certificates;
	using System.Text;
	using System.Threading.Tasks;

	using DotNetOpenAuth.Messaging;

	/// <summary>
	/// A delegating HTTP handler that signs outgoing HTTP requests
	/// with an RSA-SHA1 signature.
	/// </summary>
	public class OAuth1RsaSha1HttpMessageHandler : OAuth1HttpMessageHandlerBase {
		/// <summary>
		/// Gets or sets the certificate used to sign outgoing messages.  Used only by Consumers.
		/// </summary>
		public X509Certificate2 SigningCertificate { get; set; }

		/// <summary>
		/// Gets the signature method to include in the oauth_signature_method parameter.
		/// </summary>
		/// <value>
		/// The signature method.
		/// </value>
		protected override string SignatureMethod {
			get { return "RSA-SHA1"; }
		}

		/// <summary>
		/// Calculates the signature for the specified buffer.
		/// </summary>
		/// <param name="signedPayload">The payload to calculate the signature for.</param>
		/// <returns>
		/// The signature.
		/// </returns>
		protected override byte[] Sign(byte[] signedPayload) {
			ErrorUtilities.VerifyOperation(this.SigningCertificate != null, Strings.RequiredPropertyNotYetPreset);
			var provider = (RSACryptoServiceProvider)this.SigningCertificate.PrivateKey;
			byte[] binarySignature = provider.SignData(signedPayload, "SHA1");
			return binarySignature;
		}
	}
}

