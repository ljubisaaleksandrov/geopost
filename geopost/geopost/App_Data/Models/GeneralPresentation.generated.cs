//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1104 with alias "generalPresentation"
	/// <summary>[General] Presentation</summary>
	public partial interface IGeneralPresentation : IPublishedContent
	{
		/// <summary>Presentation Body</summary>
		Our.Umbraco.Vorto.Models.VortoValue<string> PresentationBody { get; }

		/// <summary>Presentation Image</summary>
		IPublishedContent PresentationImage { get; }

		/// <summary>Presentation Title</summary>
		Our.Umbraco.Vorto.Models.VortoValue<string> PresentationTitle { get; }

		/// <summary>Related Pages</summary>
		Umbraco.Web.Models.RelatedLinks RelatedPages { get; }
	}

	/// <summary>[General] Presentation</summary>
	[PublishedContentModel("generalPresentation")]
	public partial class GeneralPresentation : PublishedContentModel, IGeneralPresentation
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "generalPresentation";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GeneralPresentation(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GeneralPresentation, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Presentation Body
		///</summary>
		[ImplementPropertyType("presentationBody")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> PresentationBody
		{
			get { return GetPresentationBody(this); }
		}

		/// <summary>Static getter for Presentation Body</summary>
		public static Our.Umbraco.Vorto.Models.VortoValue<string> GetPresentationBody(IGeneralPresentation that) { return that.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("presentationBody"); }

		///<summary>
		/// Presentation Image
		///</summary>
		[ImplementPropertyType("presentationImage")]
		public IPublishedContent PresentationImage
		{
			get { return GetPresentationImage(this); }
		}

		/// <summary>Static getter for Presentation Image</summary>
		public static IPublishedContent GetPresentationImage(IGeneralPresentation that) { return that.GetPropertyValue<IPublishedContent>("presentationImage"); }

		///<summary>
		/// Presentation Title
		///</summary>
		[ImplementPropertyType("presentationTitle")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> PresentationTitle
		{
			get { return GetPresentationTitle(this); }
		}

		/// <summary>Static getter for Presentation Title</summary>
		public static Our.Umbraco.Vorto.Models.VortoValue<string> GetPresentationTitle(IGeneralPresentation that) { return that.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("presentationTitle"); }

		///<summary>
		/// Related Pages
		///</summary>
		[ImplementPropertyType("relatedPages")]
		public Umbraco.Web.Models.RelatedLinks RelatedPages
		{
			get { return GetRelatedPages(this); }
		}

		/// <summary>Static getter for Related Pages</summary>
		public static Umbraco.Web.Models.RelatedLinks GetRelatedPages(IGeneralPresentation that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("relatedPages"); }
	}
}
