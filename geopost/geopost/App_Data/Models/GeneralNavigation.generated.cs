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
	// Mixin content Type 1101 with alias "generalNavigation"
	/// <summary>[General] Navigation</summary>
	public partial interface IGeneralNavigation : IPublishedContent
	{
		/// <summary>Navigation Title</summary>
		Our.Umbraco.Vorto.Models.VortoValue<string> NavigationTitle { get; }

		/// <summary>Show in Breadcrumbs</summary>
		bool ShowInBreadcrumbs { get; }

		/// <summary>Show in navigation</summary>
		bool ShowInNavigation { get; }
	}

	/// <summary>[General] Navigation</summary>
	[PublishedContentModel("generalNavigation")]
	public partial class GeneralNavigation : PublishedContentModel, IGeneralNavigation
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "generalNavigation";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GeneralNavigation(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GeneralNavigation, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Navigation Title
		///</summary>
		[ImplementPropertyType("navigationTitle")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> NavigationTitle
		{
			get { return GetNavigationTitle(this); }
		}

		/// <summary>Static getter for Navigation Title</summary>
		public static Our.Umbraco.Vorto.Models.VortoValue<string> GetNavigationTitle(IGeneralNavigation that) { return that.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("navigationTitle"); }

		///<summary>
		/// Show in Breadcrumbs
		///</summary>
		[ImplementPropertyType("showInBreadcrumbs")]
		public bool ShowInBreadcrumbs
		{
			get { return GetShowInBreadcrumbs(this); }
		}

		/// <summary>Static getter for Show in Breadcrumbs</summary>
		public static bool GetShowInBreadcrumbs(IGeneralNavigation that) { return that.GetPropertyValue<bool>("showInBreadcrumbs"); }

		///<summary>
		/// Show in navigation
		///</summary>
		[ImplementPropertyType("showInNavigation")]
		public bool ShowInNavigation
		{
			get { return GetShowInNavigation(this); }
		}

		/// <summary>Static getter for Show in navigation</summary>
		public static bool GetShowInNavigation(IGeneralNavigation that) { return that.GetPropertyValue<bool>("showInNavigation"); }
	}
}
