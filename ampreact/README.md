# ampreact with Storybook
โกโ [AMP HTML][amp], [Next.js][next], [React][react], [`styled-components`][styled]
โ Based on the most trendy website boilerplate possible - adopted from https://github.com/dfrankland/ampreact.

## About

The core of `ampreact` is built on [Next.js][next], used for all the routing and
serving of pages. For styling, [`styled-components`][styled] makes it easy โ with
just a small modification to the rendering of the `<style />` tags generated,
it works nicely with [AMP HTML][amp]. Finally, [`react-amphtml`][react-amphtml]
is used for rendering all of the [AMP HTML][amp] built-ins, extensions, and
the `<script />` tags needed to use them.

The pages generated should all be properly validated by [AMP HTML][amp] ๐ฏ

## Usage

The easiest way to get started for development on Windows is to install [ConEmu](https://conemu.github.io/) (64 bit) and run the script ```start-dev.bat```.
ConEmu is a Windows console emulator that supports tabs and screen splits. The script will start a ConEmu window with 4 tabs for: Nextjs, TypeScript compilation, Storybook and an interactive console window.

All the usage and benefits of [Next.js][next] are available to `ampreact`.

*   Installation:

    ```bash
    npm install
    ```

*   Development:

    ```bash
    npm run dev
    ```

*   Production:

    ```bash
    npm run build
    npm run start
    ```
## Development

### Ststic assets

For both Storybook and Next.js the folder ```./static``` is the root of static files. 

## Example & Validation

An example of `ampreact` can be seen here: <https://ampreact-bngtmyroix.now.sh/>

### For proof of validation, either:

1.  Append `#development=1` to the URL and check the console for errors

2.  Paste the page HTML into <https://validator.ampproject.org/#url=https%3A%2F%2Fampreact-bngtmyroix.now.sh%2F>

## Deployment

Because `ampreact` is built on top of [Next.js][next] it is simple to deploy to
[Now][now] or any other cloud infrastructure providers.

[![Deploy to now][now deploy badge]][now deploy ampreact]

[amp]: https://github.com/ampproject/amphtml/
[next]: https://github.com/zeit/next.js/
[react]: https://github.com/facebook/react/
[styled]: https://github.com/styled-components/styled-components/
[react-amphtml]: https://github.com/dfrankland/react-amphtml/
[now]: https://zeit.co/now/
[now deploy badge]: https://deploy.now.sh/static/button.svg
[now deploy ampreact]: https://deploy.now.sh/?repo=https://github.com/dfrankland/ampreact
