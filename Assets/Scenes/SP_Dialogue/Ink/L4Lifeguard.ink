-> Scene1
=== Scene1 === 
DUMMY TEXT SCENE 1.
+ [Then, continue.] -> intro


=== intro ===
Boy: Hey, you're the lifeguard right?
Lifeguard: Yeah, what's up?
+ [What were you doing the day the necklace got stolen?] -> agg
+ [The technician told me to come talk to you.] -> soft


=== agg ===
Lifeguard: What's with you poking around?
+ [My mom was the manager of the hotel. I want to know the truth.] -> begin_story
=== soft ===
Lifeguard: Oh, uh. Yeah I guess I'm cool with him.
+ [He saw you by the pool the day the necklace was stolen.] -> soft2


=== soft2 ===
Lifeguard: ...
+ [...] -> soft3


=== soft3 ===
Lifeguard: Does he know anything else?
+ [Would that make a difference?] -> temp_agg
+ [No, he meant to ask you about it.] -> temp_soft


=== temp_agg ===
Lifeguard: What's with you poking around?
+ [My mom was the manager of the hotel.] -> begin_story
=== temp_soft ===
Lifeguard: Why do you care?
+ [My mom was the manager of the hotel.] -> begin_story


=== begin_story ===
Lifeguard: Oh, gotcha. Well if she knew what really happened...I guess you should know too.
+ [...] -> story


=== story ===
Lifeguard: The chef and I...we're pretty tight. We've been working together since the hotel opened. Well, I guess we won't be working here anymore...
+ [...] -> story2


=== story2 ===
Lifeguard: Anyway, that day we had gone outside for a break. It was supposed to be just for a bit, but we lost track of time.
+ [...] -> Scene2


=== Scene2 ===
DUMMY TEXT SCENE 2.
+ [Then, continue.] -> story3


=== story3 ===
Lifeguard: Chef had gone inside before me. That's when he saw it...
+ [...] -> Scene3


=== Scene3 ===
DUMMY TEXT SCENE 3.
+ [Then, continue.] -> story4


=== story4 ===
Lifeguard: Someone had drowned the pool while I was suppposed to be on duty. We tried to save him, but it was too late. We thought of saying it was an accident because we didn't want to lose our jobs.
+ [...] -> story5


=== story5 ===
Lifeguard: But truth is, your mom, the manager had already seen us.
+ [...] -> Scene4


=== Scene4 ===
DUMMY TEXT SCENE 4.
+ [Then, continue.] -> story6


=== story6 ===
Lifeguard: Hotel guests aren't supposed to swimming in the pool without a lifeguard present...but that's no excuse. Even if I try to tell myself it wasn't my fault...I can never forgive myself.
+ [...] -> story7


=== story7 ===
With what's been happening, I honestly have been thinking about a career change. One in which I won't have to be the one who gets to decide who lives or dies.
+ [...] -> story8
+ [I'm sure you'll be fine.] -> temp_story


=== temp_story ===
Thanks, kid. I hope so.
+ [...] -> story8


=== story8 ===
Oh! By the way your mom had blackmailed us for what happened. She even blackmailed the chef for other stuff from what he's told me. But you would have to ask him more about that yourself.
+ [...] -> ending


=== ending
Lifeguard: You can go talk to my good friend, the chef. Just say that I sent you and ask about the drowning.
-> END