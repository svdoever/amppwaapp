// tslint:disable:max-line-length
import * as React from "react";
import { Amp } from "react-amphtml";

const ProductColorCarousel = () => {

    return (
    <section class="container">
        <Amp.Carousel id="carousel-with-preview" width="700" height="251" layout="responsive" type="slides">
            <Amp.Img [src]="(props[currentColour].images[0] || props[props.defaultColour].images[0])"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-1.jpg"
             [srcset]="(props[currentColour].images[0] || props[props.defaultColour].images[0])"
              srcset="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-1.jpg"
             width="700" height="251" layout="responsive" alt=""></Amp.Img>
            <Amp.Img [src]="props[currentColour].images[1] || props[props.defaultColour].images[1]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-2.png"
             [srcset]="props[currentColour].images[1] || props[props.defaultColour].images[1]"
              srcset="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-2.png"
             width="700" height="251" layout="responsive" alt=""></Amp.Img>
            <Amp.Img [src]="props[currentColour].images[2] || props[props.defaultColour].images[2]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-3.png"
             [srcset]="props[currentColour].images[2] || props[props.defaultColour].images[2]"
              srcset="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-3.png"
             width="700" height="251" layout="responsive" alt=""></Amp.Img>
            <Amp.Img [src]="props[currentColour].images[3] || props[props.defaultColour].images[3]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/a5-interieur-1.jpg"
             [srcset]="props[currentColour].images[3] || props[props.defaultColour].images[3]"
              srcset="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/a5-interieur-1.jpg"
             width="700" height="251" layout="responsive" alt=""></Amp.Img>
            <Amp.Img [src]="props[currentColour].images[4] || props[props.defaultColour].images[4]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/a5-interieur-2.jpg"
             [srcset]="props[currentColour].images[4] || props[props.defaultColour].images[4]"
              srcset="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/a5-interieur-2.jpg"
             width="700" height="251" layout="responsive" alt=""></Amp.Img>
        </Amp.Carousel>
        <div class="carousel-preview">
          <div role="button" tabindex="1" on="tap:carousel-with-preview.goToSlide(index=0)">
            <Amp.Img [src]="props[currentColour].images[0] || props[props.defaultColour].images[0]"
            src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-1.jpg"
              width="60" height="40" layout="responsive" alt=""></Amp.Img>
          </div>
          <div role="button" tabindex="2" on="tap:carousel-with-preview.goToSlide(index=1)">
            <Amp.Img [src]="props[currentColour].images[1] || props[props.defaultColour].images[1]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-2.png"
             width="60" height="40" layout="responsive" alt=""></Amp.Img>
          </div>
          <div role="button" tabindex="3" on="tap:carousel-with-preview.goToSlide(index=2)">
            <Amp.Img [src]="props[currentColour].images[2] || props[props.defaultColour].images[2]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-3.png"
             width="60" height="40" layout="responsive" alt=""></Amp.Img>
          </div>
          <div role="button" tabindex="4" on="tap:carousel-with-preview.goToSlide(index=3)">
            <Amp.Img [src]="props[currentColour].images[3] || props[props.defaultColour].images[3]"
             src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/a5-interieur-1.jpg"
             width="60" height="40" layout="responsive" alt=""></Amp.Img>
          </div>
          <div role="button" tabindex="5" on="tap:carousel-with-preview.goToSlide(index=4)">
            <Amp.Img [src]="props[currentColour].images[4] || props[props.defaultColour].images[4]"
            src="https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/a5-interieur-2.jpg"
             width="60" height="40" layout="responsive" alt=""></Amp.Img>
          </div>
        </div>
    </section>
    <section class="container">
        <hr>
        <div>
          <h3 class="title-font">
            Kleur Keuze
          </h3>
          <div class="colour-selection">
            <div role="button" tabindex="1"
                 on="tap:AMP.setState({currentColour: 'briljantzwart'}),carousel-with-preview.goToSlide(index=0)"
                 class="colour-picker briljantzwart"></div>
            <div role="button" tabindex="2"
                 on="tap:AMP.setState({currentColour: 'tangoroodMetallic'}),carousel-with-preview.goToSlide(index=0)"
                 class="colour-picker tangorood-metallic"></div>
            <div role="button" tabindex="3"
                 on="tap:AMP.setState({currentColour: 'scubablauwMetallic'}),carousel-with-preview.goToSlide(index=0)"
                 class="colour-picker scubablauw-metallic"></div>
          </div>
        </div>
        <div class="selected-color-preview">
          <div class="tangorood-metallic" [class]="props[currentColour].colourClassName || props[props.defaultColour].colourClassName"></div>
          <span [text]="props[currentColour].fullColourName || props[props.defaultColour].fullColourName"
           class="title-font selected-color-preview">Tangorood Metallic</span>
           <span class="additonal-pricing-font" [text]="'+ € ' + (props[currentColour].pricePerMonth == 0 ? 0 / 100 : (props[currentColour].pricePerMonth || props[props.defaultColour].pricePerMonth)) + ' p/m'">+ € 16.01 p/m</span>
        </div>
        <hr>
    </section>
    );
}
