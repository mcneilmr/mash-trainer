# Mash-Trainer
Unity Application
___

## What is Mashing?
Button Mashing is a term used to indicate pressing a button quickly. Mash Trainer is an application that will help you achieve better 
button mashing by gauging your Mash-Per-Second (MPS).

## What do I need?
###### 1. Computer with Windows/Macintosh
![Computer](https://lh3.googleusercontent.com/jsUczKJmIwdqK4DOzHyroTmZRON0DRJLlZ6kgGwl1zMHTD2m9na0A3pSSqGNTE44bhQC3Q=s95)
###### 2. Mouse or some sort of input device to control the cursor
![Mouse](https://lh3.googleusercontent.com/6gU-VEj-WKN6vI-6YskRrDklgKEMjq0x90fEpe3drCrXqdJFMCm9-6G5ct7HbyzQMuDa=s85)


## Install

1. Download Mash Trainer [here](https://drive.google.com/file/d/1GGTJlQb45t-xtblZwh-qHavuo6ankeI4/view?usp=sharing)
1. Extract file to desired folder
3. Double-click **Mash Trainer.exe** in mash_trainer folder

## How to Play
###### Step 1:
Click **Start** button to begin count down
###### Step 2:
Press the **Mash** button as many times as possible within the time limit
###### Step 3:
Check your **MPS** for a new personal best, when the countdown is finished
###### Step 4:
Use the **Reset** button and refer to **Step 1**

## Example Code
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
## Troubleshooting
Downloading the ZIP file requires a [google](https://support.google.com/accounts/answer/27441?hl=en) account

## Contributing
Project in a repository [here](https://github.com/mcneilmr/mash-trainer)

Send a pull request through github to contribute!

## Support
If you run into any bugs email me:

mcneilmr@appstate.edu

## License
[MIT](https://choosealicense.com/licenses/mit/)





