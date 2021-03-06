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
	/// <summary>[Page] Post Category</summary>
	[PublishedContentModel("pagePostCategory")]
	public partial class PagePostCategory : PublishedContentModel, IGeneralNavigation
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pagePostCategory";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PagePostCategory(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PagePostCategory, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Category Description
		///</summary>
		[ImplementPropertyType("categoryDescription")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> CategoryDescription
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("categoryDescription"); }
		}

		///<summary>
		/// Category Icon
		///</summary>
		[ImplementPropertyType("categoryIcon")]
		public IPublishedContent CategoryIcon
		{
			get { return this.GetPropertyValue<IPublishedContent>("categoryIcon"); }
		}

		///<summary>
		/// Category Name
		///</summary>
		[ImplementPropertyType("categoryName")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> CategoryName
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("categoryName"); }
		}

		///<summary>
		/// Theme Color
		///</summary>
		[ImplementPropertyType("themeColor")]
		public string ThemeColor
		{
			get { return this.GetPropertyValue<string>("themeColor"); }
		}

		///<summary>
		/// Navigation Title
		///</summary>
		[ImplementPropertyType("navigationTitle")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> NavigationTitle
		{
			get { return Umbraco.Web.PublishedContentModels.GeneralNavigation.GetNavigationTitle(this); }
		}

		///<summary>
		/// Show in Breadcrumbs
		///</summary>
		[ImplementPropertyType("showInBreadcrumbs")]
		public bool ShowInBreadcrumbs
		{
			get { return Umbraco.Web.PublishedContentModels.GeneralNavigation.GetShowInBreadcrumbs(this); }
		}

		///<summary>
		/// Show in navigation
		///</summary>
		[ImplementPropertyType("showInNavigation")]
		public bool ShowInNavigation
		{
			get { return Umbraco.Web.PublishedContentModels.GeneralNavigation.GetShowInNavigation(this); }
		}
	}
}
