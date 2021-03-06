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
	/// <summary>[Widget] Body Section</summary>
	[PublishedContentModel("widgetBodySection")]
	public partial class WidgetBodySection : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "widgetBodySection";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public WidgetBodySection(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WidgetBodySection, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Section Image Right
		///</summary>
		[ImplementPropertyType("isSectionImageRight")]
		public bool IsSectionImageRight
		{
			get { return this.GetPropertyValue<bool>("isSectionImageRight"); }
		}

		///<summary>
		/// Section Body
		///</summary>
		[ImplementPropertyType("sectionBody")]
		public Our.Umbraco.Vorto.Models.VortoValue<IHtmlString> SectionBody
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<IHtmlString>>("sectionBody"); }
		}

		///<summary>
		/// Section Headline
		///</summary>
		[ImplementPropertyType("sectionHeadline")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> SectionHeadline
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("sectionHeadline"); }
		}

		///<summary>
		/// Section Image
		///</summary>
		[ImplementPropertyType("sectionImage")]
		public IPublishedContent SectionImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("sectionImage"); }
		}

		///<summary>
		/// Section Subheadline
		///</summary>
		[ImplementPropertyType("sectionSubheadline")]
		public Our.Umbraco.Vorto.Models.VortoValue<string> SectionSubheadline
		{
			get { return this.GetPropertyValue<Our.Umbraco.Vorto.Models.VortoValue<string>>("sectionSubheadline"); }
		}
	}
}
