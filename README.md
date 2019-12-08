# ThisNetWorks.OrchardCore.Themes
Some sample and sometimes experimental custom themes for Orchard Core

## Getting Started

Currently these themes are intended to be build using the Orchard Core dev branch.

As they progress, they may be released to NuGet or MyGet, however this is likely to be after the release of Orchard Core 1.0

To use the themes place the root of this repository in the `src/OrchardCore/OrchardCore.Themes/ThisNetWorks.OrchardCore.Themes` folder.

To use with the MyGet packages the `ProjectReference` sections in the `.csproj` files need to be changed to the equivalent `PackageReference` entries.

These are currently commented out.

## ThisNetWorksAdminTheme

This adapts the OrchardCore Admin Theme to support menu's on the left sidebar to include clickable entries on tree nodes 
(i.e. nodes that contain child items can also contain a link to an entry).

It is intended to be used in conjunction with the [ThisNetWorks.OrchardCore.AdminTree](https://github.com/ThisNetWorks/ThisNetWorks.OrchardCore.AdminTree) repository.