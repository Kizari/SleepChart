# Sleep Charter

This tool allows you to generate vertical time bar charts of sleep data exported from various tools and devices.  
&nbsp;

## How to use it

Navigate to https://kizari.github.io/SleepChart/ and follow the instructions there.  
&nbsp;

## Contributing

While I am no longer doing much to update this tool, I am more than happy to merge pull requests if any are provided. Feel free to post any issues or enhancement requests on this repository as well so myself or another developer can see them and consider implementing them.  
&nbsp;

## Developer Notes

The application runs fully client-side via WebAssembly, hence the ability to be hosted on GitHub Pages.

**Tech Stack**
- Blazor WebAssembly (tool was written several years ago, seems to be back on .NET Core 3.1)
- Bootstrap CSS Framework (uses SCSS for customisation + additional self-written CSS, compiled via a Visual Studio extension that is no longer maintained—would suggest implementing an automated Gulp task for this or something similar)

**Deployment**  
Publishing of the website is handled purely via `GitHub Actions`, which is configured in `.github/workflows/main.yml`. While I am currently maintaining this happily, this can be used on a forked repository in the event that I drop off the face of the planet and am not answering communications.
