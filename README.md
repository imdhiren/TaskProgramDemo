# TaskProgramDemo
Task Programming in c#.Task is just abstraction. Grouping of work together to tell the scheduler to execute unit of  work execute on separate thread.

Summary:
1. Two ways of using tasks
		Task.Factory.StartNew() creates and starts a Task
		new Task(() => { ... }) creates a task; use Start() to fire it
2. Tasks take an optional 'object' argument
	 	Task.Factory.StartNew(x => { foo(x) }, arg);
3. To return values, use Task<T> instead of Task
		To get the return value. use t.Result (this waits until task is complete)
4. Use Task.CurrentId to identify individual tasks.
