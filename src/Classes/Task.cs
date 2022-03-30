using System;

public class Task
{
	private float time;

	public Task()
	{
		time = 0.0;
	}

	public void getTotalTime()
    {
		//how long the task took to be ready - the chef's and barman's time sum up
    }

	public void startTask()
    {
		//the chef and barman got their task - time is started
    }

	public void stopTask()
    {
		//the chef and barman finished their task - time is stopped
    }

	public bool isReady()
    {
		//when the food and the drink is ready -> the task is stops
    }
}
