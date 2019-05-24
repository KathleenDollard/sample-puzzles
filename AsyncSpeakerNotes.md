# Async Notes

* Look at the problem, what is the fastest it could go

* Run - 5 seconds - use var
* Change to Task.Delay and Wait
* Change to async method, no result (takes <1 second)
* Use .Result - 5 seconds
* Add await - 2 seconds

* Why is pouring coffee different than frying an egg?

* What if there was a waiter? 

* Use thread.sleep in the sync method - back to 5 seconds (simulates work)
* What if I put that sleep, that work on a different thread?

