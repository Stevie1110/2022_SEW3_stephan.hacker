using _07Events;

Person stephan = new Person() { Name = "Stephan Hacker"};
Person tobias = new Person() { Name = "Tobias Nagl" };

Bar bar = new Bar() { Name = "Charlies Stüberl" };
stephan.enter(bar);
tobias.enter(bar);

bar.SpendRound();

Person markus = new Person() { Name = "Markus Leonhardsberger" };
markus.enter(bar);

bar.SpendRound();

stephan.leave(bar);

bar.SpendRound();
