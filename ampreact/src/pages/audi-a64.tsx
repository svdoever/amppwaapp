// tslint:disable:max-line-length
// tslint:disable:trailing-comma

import * as React from "react";
import Head from "next/head";
import { Amp } from "react-amphtml";
import ImageWithHeading from "../components/ImageWithHeading";
import Container from "../components/Container";
import CarConfigurator from "../components/CarConfigurator";

declare module "react" {
    interface HTMLAttributes<T> {
        hreflang?: string;
    }
}

export default () => (
    <div>
        <Head>
            <title>Gaudi A64</title>
            <link rel="canonical" href="https://amppwaapps.azurewebsites.net/amp/amp_audi-a64.html" />
            <script type="application/ld+json">
            {{
                "@context": "http://schema.org/",
                "@type": "Product",
                "name": "Gaudi A65 Lazyback",
                "image": "https://www.autoabonnement.nl/-/media/images/autoabonnement/shop/car-colours/audi/a5/a5-sportback/tangorood-metallic/audi-a5-sb-tangorood-1.jpg",
                "description": "De Gaudi A65 Lazyback combineert het design van een coupé met de functionaliteit van een Avant. Hij is bijzonder fraai om te zien, met een krachtig en vloeiend silhouet en een karakteristiek golvende schouderlijn. Het mooie uiterlijk van deze vijfdeurs bolide verbergt een verfijnd reagerend onderstel, een krachtige aandrijflijn en innovatief infotainment en connectiviteit.",
                "mpn": "656565",
                "brand": {
                    "@type": "Product",
                    "name": "Gaudi A65 Lazyback"
                },
                "aggregateRating": {
                    "@type": "AggregateRating",
                    "ratingValue": "5.0",
                    "reviewCount": "12955"
                },
                "offers": {
                    "@type": "Offer",
                    "priceCurrency": "EURO",
                    "price": "42596",
                    "priceValidUntil": "2020-11-05",
                    "itemCondition": "http://schema.org/UsedCondition",
                    "availability": "http://schema.org/InStock",
                    "seller": {
                        "@type": "Organization",
                        "name": "Executive Objects"
                    }
                }
            }}
            </script>
            <link rel="alternate" hreflang="nl-nl" href="https://amppwaapps.azurewebsites.net/amp/amp_audi-a64.html" />
        </Head>
        <h1>HELLO LITTLE  WORLD!!!</h1>
        <CarConfigurator/>
    </div>
);
