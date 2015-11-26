﻿using AspNet.Mvc.TypedRouting.Internals;

namespace Microsoft.AspNet.Mvc.Rendering
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Html.Abstractions;

    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified action
        /// by using <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent ActionLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            Expression<Action<TController>> action)
        {
            return helper.ActionLink(
                linkText,
                action,
                protocol: null,
                hostНame: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified action
        /// by using <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <param name="routeValues">
        /// An <see cref="object"/> that contains the parameters for a route. The parameters are retrieved through
        /// reflection by examining the properties of the <see cref="object"/>. This <see cref="object"/> is typically
        /// created using <see cref="object"/> initializer syntax. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the route
        /// parameters.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent ActionLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            Expression<Action<TController>> action,
            object routeValues)
        {
            return helper.ActionLink(
                linkText,
                action,
                protocol: null,
                hostНame: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: null);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified action
        /// by using <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <param name="routeValues">
        /// An <see cref="object"/> that contains the parameters for a route. The parameters are retrieved through
        /// reflection by examining the properties of the <see cref="object"/>. This <see cref="object"/> is typically
        /// created using <see cref="object"/> initializer syntax. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the route
        /// parameters.
        /// </param>
        /// <param name="htmlAttributes">
        /// An <see cref="object"/> that contains the HTML attributes for the element. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the HTML
        /// attributes.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent ActionLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            Expression<Action<TController>> action,
            object routeValues,
            object htmlAttributes)
        {
            return helper.ActionLink(
                linkText,
                action,
                protocol: null,
                hostНame: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: htmlAttributes);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified action
        /// by using <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <param name="protocol">The protocol for the URL, such as &quot;http&quot; or &quot;https&quot;.</param>
        /// <param name="hostНame">The host name for the URL.</param>
        /// <param name="fragment">The URL fragment name (the anchor name).</param>
        /// <param name="routeValues">
        /// An <see cref="object"/> that contains the parameters for a route. The parameters are retrieved through
        /// reflection by examining the properties of the <see cref="object"/>. This <see cref="object"/> is typically
        /// created using <see cref="object"/> initializer syntax. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the route
        /// parameters.
        /// </param>
        /// <param name="htmlAttributes">
        /// An <see cref="object"/> that contains the HTML attributes for the element. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the HTML
        /// attributes.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent ActionLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            Expression<Action<TController>> action,
            string protocol,
            string hostНame,
            string fragment,
            object routeValues,
            object htmlAttributes)
        {
            var expressionRouteValues = ExpressionRouteHelper.Resolve(action, routeValues);
            return helper.ActionLink(
                linkText,
                expressionRouteValues.Action,
                expressionRouteValues.Controller,
                protocol: protocol,
                hostname: hostНame,
                fragment: fragment,
                routeValues: expressionRouteValues.RouteValues,
                htmlAttributes: htmlAttributes);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified route and
        /// <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="routeName">The name of the route.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent RouteLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            string routeName,
            Expression<Action<TController>> action)
        {
            return helper.RouteLink(
                linkText,
                routeName,
                action,
                protocol: null,
                hostНame: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified route and
        /// <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="routeName">The name of the route.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <param name="routeValues">
        /// An <see cref="object"/> that contains the parameters for a route. The parameters are retrieved through
        /// reflection by examining the properties of the <see cref="object"/>. This <see cref="object"/> is typically
        /// created using <see cref="object"/> initializer syntax. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the route
        /// parameters.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent RouteLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            string routeName,
            Expression<Action<TController>> action,
            object routeValues)
        {
            return helper.RouteLink(
                linkText,
                routeName,
                action,
                protocol: null,
                hostНame: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: null);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified route and
        /// <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="routeName">The name of the route.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <param name="routeValues">
        /// An <see cref="object"/> that contains the parameters for a route. The parameters are retrieved through
        /// reflection by examining the properties of the <see cref="object"/>. This <see cref="object"/> is typically
        /// created using <see cref="object"/> initializer syntax. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the route
        /// parameters.
        /// </param>
        /// <param name="htmlAttributes">
        /// An <see cref="object"/> that contains the HTML attributes for the element. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the HTML
        /// attributes.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent RouteLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            string routeName,
            Expression<Action<TController>> action,
            object routeValues,
            object htmlAttributes)
        {
            return helper.RouteLink(
                linkText,
                routeName,
                action,
                protocol: null,
                hostНame: null,
                fragment: null,
                routeValues: routeValues,
                htmlAttributes: htmlAttributes);
        }

        /// <summary>
        /// Returns an anchor (&lt;a&gt;) element that contains a URL path to the specified route and
        /// <see cref="Expression{TDelegate}"/> for an action method,
        /// from which action name, controller name and route values are resolved.
        /// </summary>
        /// <typeparam name="TController">Controller, from which the action is specified.</typeparam>
        /// <param name="helper">The <see cref="IHtmlHelper"/> instance this method extends.</param>
        /// <param name="linkText">The inner text of the anchor element. Must not be <c>null</c>.</param>
        /// <param name="routeName">The name of the route.</param>
        /// <param name="action">
        /// The <see cref="Expression{TDelegate}"/>, from which action name, 
        /// controller name and route values are resolved.
        /// </param>
        /// <param name="protocol">The protocol for the URL, such as &quot;http&quot; or &quot;https&quot;.</param>
        /// <param name="hostНame">The host name for the URL.</param>
        /// <param name="fragment">The URL fragment name (the anchor name).</param>
        /// <param name="routeValues">
        /// An <see cref="object"/> that contains the parameters for a route. The parameters are retrieved through
        /// reflection by examining the properties of the <see cref="object"/>. This <see cref="object"/> is typically
        /// created using <see cref="object"/> initializer syntax. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the route
        /// parameters.
        /// </param>
        /// <param name="htmlAttributes">
        /// An <see cref="object"/> that contains the HTML attributes for the element. Alternatively, an
        /// <see cref="IDictionary{TKey,TValue}"/> instance containing the HTML
        /// attributes.
        /// </param>
        /// <returns>A new <see cref="IHtmlContent"/> containing the anchor element.</returns>
        public static IHtmlContent RouteLink<TController>(
            this IHtmlHelper helper,
            string linkText,
            string routeName,
            Expression<Action<TController>> action,
            string protocol,
            string hostНame,
            string fragment,
            object routeValues,
            object htmlAttributes)
        {
            var expressionRouteValues = ExpressionRouteHelper.Resolve(action, routeValues, addControllerAndActionToRouteValues: true);
            return helper.RouteLink(
                linkText,
                routeName,
                protocol: protocol,
                hostName: hostНame,
                fragment: fragment,
                routeValues: expressionRouteValues.RouteValues,
                htmlAttributes: htmlAttributes);
        }
    }
}