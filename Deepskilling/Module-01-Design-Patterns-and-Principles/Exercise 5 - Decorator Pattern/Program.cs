INotifier notifier = new EmailNotifier();

// Add SMS functionality
notifier = new SMSNotifierDecorator(notifier);

// Add Slack functionality
notifier = new SlackNotifierDecorator(notifier);

// Send notification
notifier.Send("Your order has been placed successfully.");