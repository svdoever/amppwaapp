// tslint:disable:max-line-length

import * as React from "react";
import { Amp } from "react-amphtml";
import ImageWithHeading from "./ImageWithHeading";
const Header = () => (
    <header>
      <section className="container">
        <div id="site-logo">
          <a href="https://www.autoabonnement.nl/">
            <Amp.Img src="https://www.autoabonnement.nl/-/media/images/autoabonnement/logo/logo_autoabonnement.png"
                     title="header" alt="header" layout="responsive" height="37" width="234">
            </Amp.Img>
          </a>
        </div>
      </section>
      <ImageWithHeading src="/static/img/amp.jpg" width={200} height={100} alt="Beautiful Image of a rectangle" heading="Views from Space"/>
    </header>
);

export default Header;
