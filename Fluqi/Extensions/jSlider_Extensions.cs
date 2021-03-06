﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jSlider;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a Slider widget through the library.
	/// </summary>
	public static partial class jSlider_Extensions
	{
		
		/// <summary>
		/// Creates a Slider control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Slider control</returns>
		public static Slider CreateSlider(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			Slider newSlider = new Slider(writer, id);

			return newSlider;
		}

		/// <summary>
		/// Creates a Slider control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Slider control</returns>
		public static Slider CreateSlider(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			Slider newSlider = new Slider(writer, id);

			return newSlider;
		}

	}


}