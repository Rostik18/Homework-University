import { Component } from '@angular/core';
import * as Highcharts from 'highcharts';

@Component({
    selector: 'chart-app',
    templateUrl: "./chart.component.html",
    styleUrls: ["./chart.component.scss"],
})
export class ChartComponent {
    public Highcharts: typeof Highcharts = Highcharts;
    public updateFlag: boolean = false;
    public tmin: number = 0;
    public tmax: number = 3;
    public step: number = 0.01;

    constructor() {
        //this.executExperements()
        this.executLab3()
    }

    // 3 lab

    public functionAndDerivative: Highcharts.Options = {
        title: { text: "xi(t) and Eu(t)" },
        xAxis: { type: 'linear' },
        series: []
    };

    public executLab3() {
        this.updateFlag = false;

        this.functionAndDerivative.series = [];

        this.functionAndDerivative.series.push(this.calcExpectation3());
        // this.functionAndDerivative.series.push(this.calcExpectationDer3());
        this.functionAndDerivative.series.push(this.calcExpectationEu3());

        this.updateFlag = true;
    }

    private calcExpectation3(): Highcharts.SeriesLineOptions {
        const experement: Highcharts.SeriesLineOptions = {
            name: `math expectation xi`,
            type: 'line',
            data: []
        };

        for (let t = this.tmin; t < this.tmax; t += this.step) {
            experement.data.push({ x: t, y: this.expectation_xi_lab3(t) });
        }
        return experement;
    }

    private calcExpectationDer3(): Highcharts.SeriesLineOptions {
        const experement: Highcharts.SeriesLineOptions = {
            name: `math expectation xi'`,
            type: 'line',
            data: []
        };

        for (let t = this.tmin; t < this.tmax; t += this.step) {
            experement.data.push({ x: t, y: this.expectation_xiDer_lab3(t) });
        }
        return experement;
    }

    private calcExpectationEu3(): Highcharts.SeriesLineOptions {
        const experement: Highcharts.SeriesLineOptions = {
            name: `math expectation Eu`,
            type: 'line',
            data: []
        };

        for (let t = this.tmin; t < this.tmax; t += this.step) {
            experement.data.push({ x: t, y: this.expectation_Eu_lab3(t) });
        }
        return experement;
    }

    public expectation_xi_lab3(t: number) {
        return 5 * Math.pow(Math.E, -3 * t) + t * t;
    }

    public expectation_xiDer_lab3(t: number) {
        return - 15 * Math.pow(Math.E, -3 * t) + 2 * t;
    }

    public expectation_Eu_lab3(t: number) {
        return (t * t * t - 5 * Math.pow(Math.E, -3 * t) + 5) / 3;
    }





    // 1 lab

    public randFunc: Highcharts.Options = {
        title: { text: "xi(t) = eta * e^-3t + t^2" },
        //time: { timezoneOffset: new Date().getTimezoneOffset() },
        xAxis: { type: 'linear' },
        series: []
    };

    public executExperements() {
        this.updateFlag = false;

        this.randFunc.series = [];

        this.randFunc.series.push(this.calcExpectation());
        this.randFunc.series.push(this.calcUpperLimit());
        this.randFunc.series.push(this.calcLowerLimit());

        for (let i = 0; i < 10; i++) {

            const experement: Highcharts.SeriesLineOptions = {
                name: `experement ${i}`,
                type: 'line',
                data: []
            };

            const eta = this.eta();
            for (let t = this.tmin; t < this.tmax; t += this.step) {
                experement.data.push({ x: t, y: this.rundomFunc(eta, t) });
            }
            this.randFunc.series.push(experement);
        }

        this.updateFlag = true;
    }

    private calcUpperLimit(): Highcharts.SeriesLineOptions {
        const upperLimit: Highcharts.SeriesLineOptions = {
            name: `upper limit`,
            type: 'line',
            data: []
        };
        for (let t = this.tmin; t < this.tmax; t += this.step) {
            upperLimit.data.push({ x: t, y: this.mathExpectationFunc(t) + 3 * this.sigmaFunc(t) });
        }

        return upperLimit;
    }

    private calcLowerLimit(): Highcharts.SeriesLineOptions {
        const lowerLimit: Highcharts.SeriesLineOptions = {
            name: `lower limit`,
            type: 'line',
            data: []
        };
        for (let t = this.tmin; t < this.tmax; t += this.step) {
            lowerLimit.data.push({ x: t, y: this.mathExpectationFunc(t) - 3 * this.sigmaFunc(t) });
        }

        return lowerLimit;
    }

    private calcExpectation(): Highcharts.SeriesLineOptions {
        const experement: Highcharts.SeriesLineOptions = {
            name: `math expectation`,
            type: 'line',
            data: []
        };

        for (let t = this.tmin; t < this.tmax; t += this.step) {
            experement.data.push({ x: t, y: this.mathExpectationFunc(t) });
        }
        return experement;
    }

    // sigma(t) = sqrt(9 * (e^-3t)^2)
    private sigmaFunc(t: number) {
        return 3 * Math.pow(Math.E, -3 * t); //  Math.sqrt(this.deviationFunc(t));
    }

    // D(t) = 9 * (e^-3t)^2
    private deviationFunc(t: number) {
        return 9 * Math.pow(Math.E, -6 * t);
    }

    // E(t) = 5 * e^-3t + t^2
    private mathExpectationFunc(t: number) {
        return 5 * Math.pow(Math.E, -3 * t) + t * t;
    }

    // xi(t) = eta * e^-3t + t^2
    private rundomFunc(eta: number, t: number) {
        return eta * Math.pow(Math.E, -3 * t) + t * t;
    }

    // N(5, 9) // deviation = 9 = var^2
    private eta() {
        const mean = 5;
        const stdDev = 9;

        const u1 = 1.0 - Math.random(); //uniform(0,1] random doubles
        const u2 = 1.0 - Math.random();
        const randStdNormal = Math.sqrt(-2.0 * Math.log(u1)) *
            Math.sin(2.0 * Math.PI * u2); //random normal(0,1)

        return mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
    }


    // // for Dasha
    // private sigmaFunc(t: number) {
    //     return Math.sqrt(this.deviationFunc(t));
    // }

    // private deviationFunc(t: number) {
    //     return Math.sqrt(10) * Math.pow(3 * Math.sin(2 * t), 2);
    // }

    // private mathExpectationFunc(t: number) {
    //     return 2 * (3 * Math.sin(2 * t)) + Math.pow(t + 1, 4);
    // }

    // private rundomFunc(eta: number, t: number) {
    //     return eta * (3 * Math.sin(2 * t)) + Math.pow(t + 1, 4);
    // }

    // // (2, 10)
    // private eta() {
    //     return 8 * Math.random() + 2;
    // }
}
