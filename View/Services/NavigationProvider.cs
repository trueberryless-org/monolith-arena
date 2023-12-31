﻿using System.Collections.Specialized;
using Microsoft.AspNetCore.Components;

namespace View.Services;

public class NavigationProvider
{
    private readonly NavigationManager _navigationManager;
    private readonly Dictionary<string, Page> _pages;

    public NavigationProvider(NavigationManager navigationManager)
    {
        _navigationManager = navigationManager;
        _pages = new Dictionary<string, Page>()
        {
            {
                "Root",
                new Page() { Name = "Root", Link = "/", Type = PageType.SERVICE }
            },
            {
                "Profile",
                new Page()
                {
                    Name = "Profile", Link = "/profile", Type = PageType.USER, Icon = Icons.Material.Rounded.Person
                }
            },
            {
                "Settings",
                new Page()
                {
                    Name = "Settings", Link = "/settings", Type = PageType.USER, Icon = Icons.Material.Rounded.Settings
                }
            },
            {
                "Login",
                new Page()
                {
                    Name = "Login", Link = "/login", Type = PageType.AUTHENTICATION, Icon = Icons.Material.Rounded.Login
                }
            },
            {
                "Register",
                new Page()
                {
                    Name = "Register", Link = "/register", Type = PageType.AUTHENTICATION,
                    Icon = Icons.Material.Rounded.PersonAdd
                }
            },
            {
                "Imprint",
                new Page()
                {
                    Name = "Imprint", Link = "/imprint", Type = PageType.FOOTER,
                    Icon = Icons.Material.Rounded.Assignment
                }
            },
            {
                "Sources",
                new Page()
                {
                    Name = "Source", Link = "/source", Type = PageType.FOOTER,
                    Icon = Icons.Material.Rounded.Source
                }
            },

            // Add pages here (everything else is automatic) #https://mudblazor.com/features/icons#icons
            {
                "Home",
                new Page()
                {
                    Name = "Home",
                    Link = "/",
                    Type = PageType.CONTENT,
                    Icon = Icons.Material.Rounded.Home,
                    Priority = PagePriority.IMPORTANT
                }
            },
            {
                "New Game",
                new Page()
                {
                    Name = "New Game",
                    Link = "/newgame",
                    Type = PageType.CONTENT,
                    Icon = Icons.Material.Rounded.Add,
                    Priority = PagePriority.IMPORTANT
                }
            },
            {
                "Games",
                new Page()
                {
                    Name = "Games",
                    Link = "/games",
                    Type = PageType.CONTENT,
                    Icon = Icons.Material.Rounded.VideogameAsset,
                    Priority = PagePriority.TRIVIAL
                }
            },
            {
                "Users",
                new Page()
                {
                    Name = "Users",
                    Link = "/users",
                    Type = PageType.CONTENT,
                    Icon = Icons.Material.Rounded.People,
                    Priority = PagePriority.TRIVIAL
                }
            },
            {
                "Search",
                new Page()
                {
                    Name = "Search",
                    Link = "/search",
                    Type = PageType.CONTENT,
                    Icon = Icons.Material.Rounded.Search,
                    Priority = PagePriority.TRIVIAL
                }
            },
        };

        var url = _navigationManager.Uri;

        switch (GetSubdomain(url))
        {
            case null:
                break;
            case "api":
                if (GetFirstPath(url) == string.Empty)
                {
                    
                }
                else
                {
                    _pages.Add(
                        GetFirstPath(url),
                        new Page()
                        {
                            Name = GetFirstPath(url),
                            Link = GetNewUrl(url, GetFirstPath(url)),
                            Type = PageType.RELATED
                        }
                    );
                    _pages.Add(
                        "Docs",
                        new Page()
                        {
                            Name = "Docs",
                            Link = GetNewUrl(url, "docs", GetFirstPath(url)),
                            Type = PageType.RELATED,
                            Icon = Icons.Material.Rounded.Code
                        }
                    );
                }
                break;
            case "docs":
                if (GetFirstPath(url) == string.Empty)
                {
                    
                }
                else
                {
                    _pages.Add(
                        GetFirstPath(url),
                        new Page()
                        {
                            Name = GetFirstPath(url),
                            Link = GetNewUrl(url, GetFirstPath(url)),
                            Type = PageType.RELATED
                        }
                    );
                    _pages.Add(
                        "API",
                        new Page()
                        {
                            Name = "API",
                            Link = GetNewUrl(url, "api", GetFirstPath(url)),
                            Type = PageType.RELATED,
                            Icon = Icons.Material.Rounded.Api
                        }
                    );
                }
                break;
            default:
                _pages.Add(
                    "API",
                    new Page()
                    {
                        Name = "API",
                        Link = GetNewUrl(url, "api", GetSubdomain(url)),
                        Type = PageType.RELATED,
                        Icon = Icons.Material.Rounded.Api
                    }
                );
                _pages.Add(
                    "Docs",
                    new Page()
                    {
                        Name = "Docs",
                        Link = GetNewUrl(url, "docs", GetSubdomain(url)),
                        Type = PageType.RELATED,
                        Icon = Icons.Material.Rounded.Code
                    }
                );
                break;
        }
    }

    public Page this[string name] => _pages[name];

    public List<Page> GetPages(params PageType[] types)
    {
        if (types.Length > 0)
            return _pages
                .Where(p => types.Contains(p.Value.Type))
                .Select(p => p.Value)
                .ToList();

        else
            return _pages
                .Select(p => p.Value)
                .ToList();
    }


    public List<Page> GetPagesSorted(params PageType[] types)
    {
        if (types.Length > 0)
            return _pages
                .Where(p => types.Contains(p.Value.Type))
                .Select(p => p.Value)
                .OrderBy(p => (int)p.Priority)
                .ToList();

        else
            return _pages
                .Select(p => p.Value)
                .OrderBy(p => (int)p.Priority)
                .ToList();
    }
    
    public static string GetNewUrl(string url, string? newSubdomain)
    {
        // Split the URL into its components
        var uri = new Uri(url);
        var scheme = uri.Scheme;
        var host = uri.Host;

        // Split the host into its subdomains
        var domainParts = host.Split('.').ToList();

        if (domainParts.Count < 2)
        {
            throw new ArgumentException("Domain must at least contain of Top-Level-Domain and Second-Level-Domain");
        }

        // Rebuild the URL with the new subdomain and the new path
        if (newSubdomain == null)
        {
            return $"{scheme}://{domainParts[^2]}.{domainParts[^1]}";
        }
        else
        {
            return $"{scheme}://{newSubdomain}.{domainParts[^2]}.{domainParts[^1]}";
        }
    }

    public static string GetNewUrl(string url, string? newSubdomain, string newPath)
    {
        // Split the URL into its components
        var uri = new Uri(url);
        var scheme = uri.Scheme;
        var host = uri.Host;

        // Split the host into its subdomains
        var domainParts = host.Split('.').ToList();

        if (domainParts.Count < 2)
        {
            throw new ArgumentException("Domain must at least contain of Top-Level-Domain and Second-Level-Domain");
        }

        // Rebuild the URL with the new subdomain and the new path
        if (newSubdomain == null)
        {
            return $"{scheme}://{domainParts[^2]}.{domainParts[^1]}/{newPath}";
        }
        else
        {
            return $"{scheme}://{newSubdomain}.{domainParts[^2]}.{domainParts[^1]}/{newPath}";
        }
    }

    public static string? GetSubdomain(string url)
    {
        // Split the URL into its components
        var uri = new Uri(url);
        var host = uri.Host;

        // Split the host into its subdomains
        var subdomains = host.Split('.').ToList();

        return subdomains.Count < 3 ? null : subdomains[0];
    }

    public static string GetFirstPath(string url)
    {
        var uri = new Uri(url);
        var path = uri.AbsolutePath;
        if (string.IsNullOrEmpty(path))
        {
            return string.Empty;
        }

        var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0)
        {
            return string.Empty;
        }

        return parts[0];
    }
}

public struct Page
{
    public string Name;
    public string Link;
    public PageType Type;
    public PagePriority Priority;
    public Color Color;

    // HTML Path string
    public string Icon;

    public Page()
    {
        Name = null;
        Link = null;
        Type = PageType.CONTENT;
        Priority = PagePriority.TRIVIAL;
        Icon = Icons.Material.Rounded.Icecream;
        Color = Color.Inherit;
    }
}

public enum PageType
{
    AUTHENTICATION,
    CONTENT,
    FOOTER,
    RELATED,
    SERVICE,
    USER,
}

public enum PagePriority
{
    IMPORTANT,
    TRIVIAL
}