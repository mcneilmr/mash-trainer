# Mash-Trainer
Unity Application
___

## What is Mashing?
Button Mashing is a term used to indicate pressing a button quickly. Mash Trainer is an application that will help you achieve better 
button mashing by gauging your Mash-Per-Second (MPS).

## Install
Download Mash Trainer [here](https://drive.google.com/file/d/1GGTJlQb45t-xtblZwh-qHavuo6ankeI4/view?usp=sharing)
## Usage

## Code
Mash Trainer is built upon the simple idea to press a button and increment a counter.
```C#
    public void mashIncrement(){
        //as long as there is time on the clock
        if (seconds > 0.0f){

            //increment mashcounter
            mashCount++;

            //update the text field
            displayScore.text = mashCount.ToString();

        }//end if seconds > 0.0f
    }//end mash Button
```





