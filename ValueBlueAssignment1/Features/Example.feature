Feature: Example

The Feature File for Example.com

@tag1
Scenario: FinishMe
When I start the browser
And I navigate to 'http://example.com'
And I click on the 'More Information...' link
Then a link with text 'RFC 2606' must be present
And a link with text 'RFC 6761' must be present 
Then I click on the 'Domain Names' link
And the 'Domain Names' box must contain 'Root Zone Management' at index '2'
