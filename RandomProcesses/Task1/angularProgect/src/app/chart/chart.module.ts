import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HighchartsChartModule } from 'highcharts-angular';
import { ChartComponent } from './chart.component';

@NgModule({
    imports: [BrowserModule, FormsModule, HighchartsChartModule],
    declarations: [ChartComponent],
    exports: [ChartComponent],
    bootstrap: [ChartComponent]
})
export class ChartModule { }